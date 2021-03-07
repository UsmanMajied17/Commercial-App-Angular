import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-presentation-main',
  template: `<router-outlet></router-outlet>`,
  styleUrls: ['./presentation-main.component.css']
})
export class PresentationMainComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
