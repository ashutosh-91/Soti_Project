import { Component } from '@angular/core';
import { NgModel } from '@angular/forms';
@Component({
  selector: 'app-update-doctor',
  templateUrl: './update-doctor.component.html',
  styleUrls: ['./update-doctor.component.css']
})
export class UpdateDoctorComponent {

  update(data: any){
    console.log("Submitted",data);
  }
}
