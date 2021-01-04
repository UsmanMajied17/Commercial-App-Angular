import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { TestBed } from '@angular/core/testing';

import { AuthService } from './auth.service';

describe('AuthService', () => {
  const users = {
    "loginUsers": [
      {
        "id": 1,
        "name": "Usman Majied",
        "email": "usmanmajied17@gmail.com",
        "password": "abc@123"
      },
      {
        "id": 2,
        "name": "Usman Mania",
        "email": "usmanmania@gmail.com",
        "password": "abc@123"
      },
      {
        "id": 1,
        "name": "Cory",
        "email": "cory@gmail.com",
        "password": "abc@123"
      }
    ]
  }


  let service: AuthService;
  let http: HttpTestingController;
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpClientTestingModule
      ],
      providers: [AuthService]
    });
    service = TestBed.inject(AuthService);
    http = TestBed.get(HttpTestingController);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
