import { NgModule } from '@angular/core';
import { PapiComponent } from '../papi/papi.component';
import { RouterModule, Routes } from "@angular/router";

const appRoutes: Routes = [
  { path: 'papi', component: PapiComponent }
];

@NgModule({
  imports: [
    RouterModule.forChild(appRoutes)
  ],
  exports: [
    RouterModule
  ]
})
export class PapiRoutingModule { }
