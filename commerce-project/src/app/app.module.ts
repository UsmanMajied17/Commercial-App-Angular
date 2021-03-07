import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule, FaIconLibrary } from '@fortawesome/angular-fontawesome';
import { MainDashboardComponent } from './main-dashboard/main-dashboard.component';
import { SidenavComponent } from './shared/components/sidenav/sidenav.component';
import { MainByeByteComponent } from './main-bye-byte/main-bye-byte.component';
import { faTachometerAlt } from '@fortawesome/free-solid-svg-icons';

@NgModule({
  declarations: [
    AppComponent,
    MainDashboardComponent,
    SidenavComponent,
    MainByeByteComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule,
    AppRoutingModule,
    FontAwesomeModule
  ],
  exports:[FontAwesomeModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
  /**
   *
   */
  constructor(private library: FaIconLibrary) {
    library.addIcons(faTachometerAlt);

  }
 }
