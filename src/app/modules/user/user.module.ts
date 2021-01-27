import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { CreateComponent } from './create/create.component';
import { FormsModule } from '@angular/forms';
import { UserService } from 'src/app/services/user.service';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [UserComponent, CreateComponent],
  imports: [
    CommonModule,
    UserRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers:[UserService]
})
export class UserModule { }
