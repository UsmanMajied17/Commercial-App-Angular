import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PresentationRoutingModule } from './presentation-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ByeBteComponent } from './bye-bte/bye-bte.component';
import { PriceCalculatorComponent } from './price-calculator/price-calculator.component';
import { TransactionHistoryComponent } from './transaction-history/transaction-history.component';
import { AffliliateComponent } from './affliliate/affliliate.component';
import { PresentationMainComponent } from './presentation-main.component';
import { FaIconLibrary, FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faCog } from '@fortawesome/free-solid-svg-icons';


@NgModule({
  declarations: [
    DashboardComponent,
    ByeBteComponent,
    PriceCalculatorComponent,
    TransactionHistoryComponent,
    PresentationMainComponent,
    AffliliateComponent],
  imports: [
    CommonModule,
    PresentationRoutingModule,
    FontAwesomeModule
  ]
})
export class PresentationModule {
  constructor(private library: FaIconLibrary) {
    library.addIcons(faCog);
   }

}
