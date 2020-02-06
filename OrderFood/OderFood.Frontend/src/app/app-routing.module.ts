import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppLayoutComponent } from './components/_layout';
import {
  HomeComponent
} from './components'
export const routes: Routes = [
  {
    path: '',component: AppLayoutComponent,
    children: [
      { path: '', component: HomeComponent, pathMatch: 'full' },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
