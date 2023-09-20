import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { timeCheck } from './timeCheck';
@Component({
  selector: 'app-update-doctor',
  templateUrl: './update-doctor.component.html',
  styleUrls: ['./update-doctor.component.css']
})
export class UpdateDoctorComponent {
  constructor(private fb:FormBuilder){}
  surgeryForm = this.fb.group({
    startTime: ['', [Validators.required,Validators.max(23),Validators.min(0)]],
    endTime: ['', [Validators.required,Validators.max(23),Validators.min(0)]],

}, {
    validators: timeCheck('startTime', 'endTime')
})
  
// get f() { 
//   return this.surgeryForm.controls;
//  }
get startTime(){
  return this.surgeryForm.get('startTime');
}
get endTime(){
  return this.surgeryForm.get('endTime');
}
}
