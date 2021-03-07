import { Component, OnInit } from '@angular/core';
import { faCog, faThumbsUp, faShoppingCart, faUsers, } from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  faCog = faCog;
  faThumbsUp = faThumbsUp;
  faShoppingCart = faShoppingCart;
  faUsers = faUsers;
  constructor() { }

  ngOnInit(): void {
  }

}
