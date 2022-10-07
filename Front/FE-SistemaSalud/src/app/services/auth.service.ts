import { Injectable } from '@angular/core';
import { BehaviorSubject, tap } from 'rxjs';
import { IResponse } from '../components/login/models/response';
import { UserLogin } from '../components/login/models/user';
import { ApiService } from '../components/login/services/api.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private _isLoggedIn$ = new BehaviorSubject<boolean>(false);
  isLoggedIn$ = this._isLoggedIn$.asObservable();
  
  constructor(private apiService: ApiService) { 
    const token = localStorage.getItem('profanis_auth');
    this._isLoggedIn$.next(!!token);
  }

  login(request: UserLogin) {
    return this.apiService.login(request).pipe(
      tap((response: any) => {
        this._isLoggedIn$.next(true);
        localStorage.setItem('profanis_auth', response.jWtoken);
      })
    );
  }
}
