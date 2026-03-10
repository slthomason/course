import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HelloWorldComponent } from './hello-word.component';
import { HelloWorldCliComponent } from './hello-world-cli/hello-world-cli.component';
import { ChildComponent, ParentComponent } from './parent.component';
import { DirectiveExampleComponent } from './directive-example/directive-example.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ReactiveFormExampleComponent } from './reactive-form-example/reactive-form-example.component';
import { TemplateDrivenExampleComponent } from './template-driven-example/template-driven-example.component';
import { FirstComponent } from './first/first.component';
import { SecondComponent } from './second/second.component';
import { HobbyDetailComponent } from './hobby-detail/hobby-detail.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { AdminComponent } from './admin/admin.component';
import { AdminUsersComponent } from './admin-users/admin-users.component';
import { AdminReportsComponent } from './admin-reports/admin-reports.component';
import { LoginComponent } from './login/login.component';
import { GitUserListComponent } from './git-user-list/git-user-list.component';
import {HttpClientModule} from '@angular/common/http';
import { CustomObsersablesComponent } from './custom-obsersables/custom-obsersables.component';
import { DialogComponent } from './dialog/dialog.component'
import {BrowserAnimationsModule} from '@angular/platform-browser/animations'


@NgModule({
  declarations: [
    AppComponent,
    HelloWorldComponent,
    HelloWorldCliComponent,
    ParentComponent,
    ChildComponent,
    DirectiveExampleComponent,
    ReactiveFormExampleComponent,
    TemplateDrivenExampleComponent,
    FirstComponent,
    SecondComponent,
    HobbyDetailComponent,
    NotFoundComponent,
    AdminComponent,
    AdminUsersComponent,
    AdminReportsComponent,
    LoginComponent,
    GitUserListComponent,
    CustomObsersablesComponent,
    DialogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
