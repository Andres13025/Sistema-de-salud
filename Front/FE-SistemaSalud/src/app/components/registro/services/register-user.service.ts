import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Userinfo } from '../models/models';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json',
    'Access-Control-Allow-Origin': '*'
  })
};

@Injectable({
  providedIn: 'root'
})
export class RegisterUserService {

  private myAppUrl: string = environment.endpoint;
  private myApiUrl: string = 'api/User/userinfo';

  constructor(private http: HttpClient) { }

  adduser(request: Userinfo): Observable<any> {
    return this.http.post<any>(`${this.myAppUrl}${this.myApiUrl}`, JSON.stringify(request), httpOptions)
    .pipe(catchError(this.handlerError));
  }

  handlerError(error: HttpErrorResponse){
    window.alert("unknow error");
    return throwError("unknow error");
  }
}
