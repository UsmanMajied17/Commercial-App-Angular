import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AffliliateComponent } from './affliliate/affliliate.component';
import { ByeBteComponent } from './bye-bte/bye-bte.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PresentationMainComponent } from './presentation-main.component';
import { PriceCalculatorComponent } from './price-calculator/price-calculator.component';
import { TransactionHistoryComponent } from './transaction-history/transaction-history.component';


const routes: Routes = [
  { path: '', component: PresentationMainComponent,
  children: [
    { path: 'dashboard', component: DashboardComponent },
    { path: 'buy-bte', component: ByeBteComponent },
    { path: 'price-calculator', component: PriceCalculatorComponent },
    { path: 'affiliates', component: AffliliateComponent },
    { path: 'transaction-history', component: TransactionHistoryComponent },
  ]

}


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PresentationRoutingModule { }
