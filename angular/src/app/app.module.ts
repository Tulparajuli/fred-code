import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { PapiModule } from '../papi/papi.module';
import { PapiComponent } from '../papi/papi.component';
import { RouterModule, Routes } from "@angular/router";

const appRoutes: Routes = [
  { path: 'papi', component: PapiComponent }
];

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, PapiModule, RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
