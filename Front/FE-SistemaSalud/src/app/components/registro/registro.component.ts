import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {

  constructor(private _formBuilder: FormBuilder) { }

  typedoc: any[] = [
    {value: '1', viewValue: 'CC'},
    {value: '2', viewValue: 'TI'},
  ];

  genero: any[] = [
    {value: '1', viewValue: 'MASCULINO'},
    {value: '2', viewValue: 'FEMENINO'},
    {value: '3', viewValue: 'OTRO'},
  ];

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
    console.log(this.firstFormGroup.value);
  }
  form2(){
    console.log(this.secondFormGroup.value);
  }
  form3(){
    console.log(this.thirdFormGroup.value);
  }
}
