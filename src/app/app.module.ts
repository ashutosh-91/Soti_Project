import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddDoctorComponent } from './components/add-doctor/add-doctor.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { UpdateDoctorComponent } from './components/update-doctor/update-doctor.component';
import { FormsModule,ReactiveFormsModule } from "@angular/forms";
import { ViewDoctorComponent } from './components/view-doctor/view-doctor.component';

@NgModule({
  declarations: [
    AppComponent,
    AddDoctorComponent,
    NavbarComponent,
    UpdateDoctorComponent,
    ViewDoctorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
