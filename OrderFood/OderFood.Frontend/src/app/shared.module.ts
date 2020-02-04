import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedComponents } from './shared-component'
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    SharedComponents
  ],
  imports: [
    RouterModule,
    CommonModule
  ],
  exports: [
    SharedComponents,
  ],
})
export class SharedModule { }
