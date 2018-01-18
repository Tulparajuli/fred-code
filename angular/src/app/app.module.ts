import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { PapiModule } from '../papi/papi.module';
import { PapiComponent } from '../papi/papi.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, PapiModule
  ],
  providers: [],
  bootstrap: [AppComponent, PapiComponent]
})
export class AppModule { }
