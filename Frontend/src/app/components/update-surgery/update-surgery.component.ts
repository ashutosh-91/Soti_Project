import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { timeCheck } from './timeCheck';
@Component({
  selector: 'app-update-surgery',
  templateUrl: './update-surgery.component.html',
  styleUrls: ['./update-surgery.component.css']
})
export class UpdateSurgeryComponent {
  constructor(private fb:FormBuilder){}
  surgeryForm = this.fb.group({
    startTime: ['', [Validators.required,Validators.max(23),Validators.min(0),Validators.pattern("^[0-9]*$")]],
    endTime: ['', [Validators.required,Validators.max(23),Validators.min(0),Validators.pattern("^[0-9]*$")]],

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
