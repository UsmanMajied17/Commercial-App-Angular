import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from 'src/app/test/models/user.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private httpClient: HttpClient) {}

   getAllUsers(): Observable<User[]> {
      const url = 'http://localhost:3000/loginUsers';
      return this.httpClient.get<User[]>(url);
   }
}
