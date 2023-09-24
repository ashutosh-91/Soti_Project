import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ISurgery } from 'src/app/models/surgery.model';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-view-todays-surgery',
  templateUrl: './view-todays-surgery.component.html',
  styleUrls: ['./view-todays-surgery.component.css']
})
export class ViewTodaysSurgeryComponent {
  surgeries:ISurgery[]=[];
  constructor( private router:Router,private dataService:DataService){
    this.dataService.getAllSurgeries().subscribe((data:any) => {
        this.surgeries=data;
      }
    );
  }
  editSurgery(surgery:any){
    console.log(surgery);
    this.router.navigate(['/editSurgery',surgery.surgeryId],{
      state:
        {data:surgery }    
    })
  }
}
