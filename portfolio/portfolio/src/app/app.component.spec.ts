import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { AuthService } from './core/services/auth.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

describe('AppComponent', () => {
  let component: AppComponent;
  let fixture: ComponentFixture<AppComponent>;
  let authService: AuthService;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        HttpClientTestingModule
      ],
      declarations: [
        AppComponent
      ],
    }).compileComponents();
    authService = TestBed.inject(AuthService);
    fixture = TestBed.createComponent(AppComponent);
    component = fixture.componentInstance;  
  });

  it('should create the app', () => {
    expect(component).toBeTruthy();
  });

  it(`should have as title 'portfolio'`, () => {
    expect(component.title).toEqual('portfolio');
  });

  it('should render Login Title', () => {
    fixture.detectChanges();
    const titleElements = fixture.debugElement.queryAll(By.css('mat-card-title'));
    expect(titleElements.length).toBe(1);
    expect(titleElements[0].nativeElement.innerHTML).toBe('Login');
  });
  it('should call login method',() => {
    spyOn(component,'login');
    component.login();
    fixture.detectChanges();
    expect(component.login).toHaveBeenCalled();
  });
  describe('User Tests', () => {
    it('should call getAllUsers method', () => {
      spyOn(authService, 'getAllUsers');
      fixture.detectChanges();
      expect(authService.getAllUsers).toHaveBeenCalled();
    });
  });
  
});

