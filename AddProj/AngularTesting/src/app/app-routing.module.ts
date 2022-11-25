import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegistrationListComponent } from './components/registration-list/registration-list.component';
import { RegistrationComponent } from './components/registration/registration.component';


const routes: Routes = [{path:"Registration", component:RegistrationComponent},
{
  path:"RegistrationList",component:RegistrationListComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
