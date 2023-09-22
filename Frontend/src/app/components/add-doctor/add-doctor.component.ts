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
  doctorModel=new Doctor();
  constructor(private dataService:DataService, private router:Router){

  }
  displayMessage(){
    this.message = 'Doctor successfully added'
  }
  addDoctor(){
    console.log(this.doctorModel);
    this.dataService.addDoctor(this.doctorModel).subscribe((data: any) => {  
      console.log(data);
  });
     
     this.router.navigate(['/home']);
  }
}
