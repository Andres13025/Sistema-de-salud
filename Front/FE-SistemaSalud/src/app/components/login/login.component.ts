import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { UserLogin } from './models/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  form = new FormGroup({
    username: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required),
  });

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit(): void {
  }

  submitForm() {
    if (this.form.invalid) {
      return;
    }

    let username = this.form.get('username')?.value;
    let pass = this.form.get('password')?.value;
    let request: UserLogin = {
      username: username,
      password: pass
    }
    if(username == null || pass == null){
      username = '';
      pass = '';
    }

    this.authService
      .login(request)
      .subscribe((response) => {
        var x = response;
        console.log("logged");
        //this.router.navigate(['/dashboard']);
      });

  }

}
