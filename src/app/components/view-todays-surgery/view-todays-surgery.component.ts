import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ISurgery } from 'src/app/models/surgery.model';

@Component({
  selector: 'app-view-todays-surgery',
  templateUrl: './view-todays-surgery.component.html',
  styleUrls: ['./view-todays-surgery.component.css']
})
export class ViewTodaysSurgeryComponent {
  surgeries:ISurgery[]=[{surgeryId: 1,doctorId:1,surgeryDate:new Date("Fri Dec 08 2019 07:44:57"),startTime:1,endTime:2,surgeryCategory:"ABC"}];
  constructor( private router:Router){}
  editSurgery(surgery:any){
    this.router.navigate(['/editSurgery',surgery.surgeryId])
  }
}
