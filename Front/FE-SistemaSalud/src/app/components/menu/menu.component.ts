import { Component, OnInit } from '@angular/core';
import {MatMenuModule} from '@angular/material/menu';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  constructor(private route: Router) { }

  ngOnInit(): void {
  }

  cerrarsesion(){
    localStorage.removeItem('profanis_auth');
    this.route.navigate(['login']);
  }
}
