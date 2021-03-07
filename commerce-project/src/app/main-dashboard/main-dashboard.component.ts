import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-main-dashboard',
  templateUrl: './main-dashboard.component.html',
  styleUrls: ['./main-dashboard.component.css']
})
export class MainDashboardComponent implements OnInit {

  constructor() { }

  isByeByteSelected: boolean = false;
  ngOnInit(): void {
  }
  showBteSection(isBteSelected: boolean): void {
    if(isBteSelected) {
      this.isByeByteSelected = true;
    } else {
      console.log('in else')
      this.isByeByteSelected = false;
    }


  }
}
