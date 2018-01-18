import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { PapiModule } from '../papi/papi.module';
import { AppRoutingModule } from './app.module.routing';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, PapiModule, AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
