import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminReportsComponent } from './admin-reports/admin-reports.component';
import { AdminUsersComponent } from './admin-users/admin-users.component';
import { AdminComponent } from './admin/admin.component';
import { AuthGuard } from './auth.gaurd';
import { FirstComponent } from './first/first.component';
import { HobbyDetailComponent } from './hobby-detail/hobby-detail.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { SecondComponent } from './second/second.component';

const routes: Routes = [{
  path: "first",
  component: FirstComponent,
  title: "This is my first component"
},
{
  path: "second",
  component: SecondComponent
},
{
  path: "hobby-detail/:id",
  component: HobbyDetailComponent
},
// {
//   path: "",
//   component: FirstComponent
// },
{
  path: "",
  redirectTo: "/first",
  pathMatch: "full"
},
{
  path: "admin",
  component: AdminComponent,
  canActivate: [AuthGuard],
  children: [
    {
      path: "admin-users",
      component: AdminUsersComponent
    },
    {
      path: "admin-reports",
      component: AdminReportsComponent
    },
  ]
},

{
  path: "**",
  component: NotFoundComponent
},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
