import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { timeCheck } from './timeCheck';
import { ISurgery } from 'src/app/models/surgery.model';
import { Router } from '@angular/router';
import { DataService } from 'src/app/services/data.service';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-update-surgery',
  templateUrl: './update-surgery.component.html',
  styleUrls: ['./update-surgery.component.css']
})
export class UpdateSurgeryComponent {
  surgery: ISurgery;
  surgeryForm!: FormGroup;
  // alertClass = ""
  // textMessage = ""
  constructor(private fb: FormBuilder, private route: Router, private http: DataService) {
    this.surgery = route.getCurrentNavigation()?.extras.state?.['data'];

    console.log(this.surgery);

    this.surgeryForm = this.fb.group({
      surgeryCategory: [this.surgery.surgeryCategory],
      surgeryId: [this.surgery.surgeryId],
      doctorId: [this.surgery.doctorId],
      surgeryDate: [this.surgery.surgeryDate],
      startTime: [this.surgery.startTime, [Validators.required, Validators.max(23), Validators.min(0), Validators.pattern("^[0-9]*$")]],
      endTime: [this.surgery.endTime, [Validators.required, Validators.max(23), Validators.min(0), Validators.pattern("^[0-9]*$")]],

    }, {
      validators: timeCheck('startTime', 'endTime')
    })
  }

  updateSurgery() {
    console.log(this.surgeryForm.value);
    this.http.updateSurgery(this.surgeryForm.value).subscribe(
      (data: any) => {
        if (data == true) {
          //On successful excecution of service
          // this.textMessage = 'Surgery details updtaed Successfully';
          // this.alertClass = 'alert alert-success';
          // console.log(this.textMessage);
          Swal.fire('Successfully Updated', '', 'success')
        }
        else {
          // this.textMessage = 'Surgery details updated successfully';
          // this.alertClass = 'alert alert-danger';
          // console.log(this.textMessage);
          Swal.fire('Failed to Update','','error')
        }
      },

      (error: any) => {
        //In case of error
        // this.textMessage = 'Some error occured';
        // this.alertClass = 'alert alert-danger';
        // console.error(this.textMessage);
        Swal.fire('Failed to Update','','error')
      }
    );


    this.route.navigate(['/todaySurgery'])
  }

  // get f() { 
  //   return this.surgeryForm.controls;
  //  }
  get startTime() {
    return this.surgeryForm.get('startTime');
  }
  get endTime() {
    return this.surgeryForm.get('endTime');
  }
}
