import { Component } from '@angular/core';
import { NgModel } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IDoctor } from 'src/app/models/doctor.model';
import { Doctor } from 'src/app/models/doctorClass.model';
import { DataService } from 'src/app/services/data.service';
@Component({
  selector: 'app-update-doctor',
  templateUrl: './update-doctor.component.html',
  styleUrls: ['./update-doctor.component.css']
})
export class UpdateDoctorComponent {
  textMessage=''
  alretClass=''
  doctorModel=new Doctor();
  constructor(private dataService:DataService,private activatedRoute:ActivatedRoute, private router:Router){
    this.doctorModel.DoctorId=Number(this.activatedRoute.snapshot.paramMap.get('docId'));
  }
  updateDoctor(){

    console.log(this.doctorModel);
    this.dataService.updateDoctor(this.doctorModel).subscribe((data: any) => {  
      console.log(data);
  });     
     this.router.navigate(['/home']);
  }
}
