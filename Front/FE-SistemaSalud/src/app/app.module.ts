import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './components/login/login.component';
import { RegistroComponent } from './components/registro/registro.component';

import { RouterModule, Routes } from '@angular/router'
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MenuComponent } from './components/menu/menu.component';
import { IsAuthenticatedGuard } from './is-authenticated.guard';
import {MatMenuModule} from '@angular/material/menu';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'registro', component: RegistroComponent},
  {path: 'menu', component:MenuComponent, canActivate:[IsAuthenticatedGuard]},
  {path: '', redirectTo: '/login', pathMatch: 'full'}
]
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegistroComponent,
    MenuComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(routes),
    ReactiveFormsModule,
    HttpClientModule,
    MatMenuModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
