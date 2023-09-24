import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { timeCheck } from './timeCheck';
import { ISurgery } from 'src/app/models/surgery.model';
import { Router } from '@angular/router';
import { DataService } from 'src/app/services/data.service';
@Component({
  selector: 'app-update-surgery',
  templateUrl: './update-surgery.component.html',
  styleUrls: ['./update-surgery.component.css']
})
export class UpdateSurgeryComponent {
  surgery: ISurgery;
  surgeryForm!: FormGroup;
  constructor(private fb:FormBuilder, private route:Router,private http:DataService){
    this.surgery=route.getCurrentNavigation()?.extras.state?.['data'];

    console.log(this.surgery);

    this.surgeryForm = this.fb.group({
      surgeryCategory:[this.surgery.surgeryCategory],
      surgeryId:[this.surgery.surgeryId],
      doctorId:[this.surgery.doctorId],
      surgeryDate:[this.surgery.surgeryDate],
      startTime: [this.surgery.startTime, [Validators.required,Validators.max(23),Validators.min(0),Validators.pattern("^[0-9]*$")]],
      endTime: [this.surgery.endTime, [Validators.required,Validators.max(23),Validators.min(0),Validators.pattern("^[0-9]*$")]],
  
  }, {
      validators: timeCheck('startTime', 'endTime')
  })
  }

    updateSurgery(){
      console.log(this.surgeryForm.value);
      this.http.updateSurgery(this.surgeryForm.value).subscribe((data:any)=>{
        console.log(this.surgeryForm);
      });
      this.route.navigate(['/todaySurgery'])
    }
  
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
