import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../core/core.module';
import { DataModule } from '../data/data.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    CoreModule,
    DataModule
  ]
})
export class PresentationModule { }
