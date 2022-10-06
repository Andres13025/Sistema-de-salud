import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  login(username: string, password: string) {
    return this.http.post<any>('login', { username, password }).pipe(catchError(this.handlerError));
  }

  handlerError(error: HttpErrorResponse){
    window.alert("error");
    return throwError("error jaja");
  }
}
