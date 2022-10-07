import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { catchError, Observable, observable, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UserLogin } from '../models/user';
import { IResponse } from '../models/response';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json',
    'Access-Control-Allow-Origin': '*'
  })
};

const headers = new HttpHeaders().set('Content-Type', 'text/plain; charset=utf-8');

@Injectable({
  providedIn: 'root'
})


export class ApiService {

  private myAppUrl: string = environment.endpoint;
  private myApiUrl: string = 'api/token';
  constructor(private http: HttpClient) { }

  login(request: UserLogin): Observable<any> {
    return this.http.post<any>(`${this.myAppUrl}${this.myApiUrl}`, JSON.stringify(request), httpOptions)
    .pipe(catchError(this.handlerError));
  }

  handlerError(error: HttpErrorResponse){
    window.alert("error");
    return throwError("error jaja");
  }
}
