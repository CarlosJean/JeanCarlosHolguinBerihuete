import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  departments = Array();

  formData = {
    names : null,
    surnames : null,
    genre: null,
    document: null,
    birthday:null,
    department: null,
    position: null,
    supervisor:null
  };


  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.userService.getDepartments().subscribe((department)=>{
      console.log(department);      
    });
  }

  submit(){

    console.log(this.formData);

  }
}
