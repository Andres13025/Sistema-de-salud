import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Userinfo } from './models/models';
import { Persona } from './models/persona';
import { UserLogin } from './models/userLogin';
import { RegisterUserService } from './services/register-user.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {

  constructor(private _formBuilder: FormBuilder, private registerUserService: RegisterUserService,) { }

  typedoc: any[] = [
    {value: 1, viewValue: 'CC'},
    {value: 2, viewValue: 'TI'},
  ];

  genero: any[] = [
    {value: 1, viewValue: 'MASCULINO'},
    {value: 2, viewValue: 'FEMENINO'},
    {value: 3, viewValue: 'OTRO'},
  ];

  Form1: any;
  Form2: any;

  firstFormGroup = this._formBuilder.group({
    usuario: ['', Validators.required],
    pass: ['', Validators.required],
    confirm_pass: ['', Validators.required],
  });
  secondFormGroup = this._formBuilder.group({
    firstname: ['', Validators.required],
    secondname: ['', Validators.required],
    firstlastname: ['', Validators.required],
    secondlastname: ['', Validators.required],
    type_document: ['', Validators.required],
    document: ['', Validators.required],
    email: ['', Validators.required],
    datebirth: ['', Validators.required],
    genero: ['', Validators.required]
  });
  thirdFormGroup = this._formBuilder.group({
    firstname: ['', Validators.required],
    secondname: ['', Validators.required],
    firstlastname: ['', Validators.required],
    secondlastname: ['', Validators.required],
    type_document: ['', Validators.required],
    document: ['', Validators.required],
    email: ['', Validators.required],
    datebirth2: ['', Validators.required],
    genero: ['', Validators.required]
  });
  isEditable = true;

  ngOnInit(): void {
  }

  form1(){
    this.Form1 = this.firstFormGroup.value;
  }
  form2(){
    this.Form2 = this.firstFormGroup.value;
  }
  form3(){
    let credential : UserLogin = {
      username: this.firstFormGroup.controls.usuario.value,
        password: this.firstFormGroup.controls.pass.value
    }
    let infouser1 : Persona = {
      primer_Nombre: this.secondFormGroup.controls.firstname.value,
      segundo_Nombre: this.secondFormGroup.controls.secondname.value,
      primer_Apellido: this.secondFormGroup.controls.firstlastname.value,
      segundo_Apellido: this.secondFormGroup.controls.secondlastname.value,
      identificacion: this.secondFormGroup.controls.document.value,
      id_Tipo_identificacion: +this.secondFormGroup.controls.type_document.value,
      fecha_nacimiento: "2022-10-01",
      id_Genero: +this.secondFormGroup.controls.genero.value,
      correo: this.secondFormGroup.controls.email.value,
      parentesco: "null"
    }
    let infouser2 : Persona = {
      primer_Nombre: this.thirdFormGroup.controls.firstname.value,
      segundo_Nombre: this.thirdFormGroup.controls.secondname.value,
      primer_Apellido: this.thirdFormGroup.controls.firstlastname.value,
      segundo_Apellido: this.thirdFormGroup.controls.secondlastname.value,
      identificacion: this.thirdFormGroup.controls.document.value,
      id_Tipo_identificacion: +this.thirdFormGroup.controls.type_document.value,
      fecha_nacimiento:  "2022-10-01",
      id_Genero: +this.thirdFormGroup.controls.genero.value,
      correo: this.thirdFormGroup.controls.email.value,
      parentesco: "null"
    }
    let request: Userinfo = {
      firstformGroup: credential,
      secondformGroup: infouser1,
      thirdformGroup: infouser2
    }

    this.registerUserService.adduser(request).subscribe((response) => {
      if(response){
        window.alert("usuario creado exitosamente");
        console.log("usuario creado exitosamente");
      }else{
        window.alert("usuario creado exitosamente");
        console.log("ocurrio un error");
      }
    })
    
  }
}
