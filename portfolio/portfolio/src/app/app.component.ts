import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { AuthService } from './core/services/auth.service';
import { User } from './test/models/user.model';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  /**
   *
   */
  constructor(private authService: AuthService) {
   

  }
  title = 'portfolio';
  hide = true;
  users$ : Observable<User[]> = new Observable();
  ngOnInit(): void {
    this.users$ = this.authService.getAllUsers();
  }
 

  login() {

  }
}
