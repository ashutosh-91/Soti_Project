import { Component } from '@angular/core';
import { NgModel } from '@angular/forms';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Doctor } from 'src/app/models/doctorClass.model';
import { DataService } from 'src/app/services/data.service';
@Component({
  selector: 'app-add-doctor',
  templateUrl: './add-doctor.component.html',
  styleUrls: ['./add-doctor.component.css']
})
export class AddDoctorComponent {
  message: string = '';
  alertClass = ""
  textMessage = ""
  doctorModel=new Doctor();
  constructor(private dataService:DataService, private router:Router){

  }
  
  addDoctor(){
    console.log(this.doctorModel);
    this.dataService.addDoctor(this.doctorModel).subscribe(
      (response: any) => {
        // On successful execution of service
        this.textMessage ='Doctors Fetched Successfully'; // Set showMsgDiv appropriately
        this.alertClass = 'alert alert-success';
        console.log(this.textMessage);
      },
  
      (error: any) => {
        // In case of error
        this.textMessage ='Error fetching doctors'; // Store the error message
        this.alertClass = 'alert alert-danger';
        console.error(this.textMessage);
  
      }
  );
     
     //this.router.navigate(['/home']);
  }
}
