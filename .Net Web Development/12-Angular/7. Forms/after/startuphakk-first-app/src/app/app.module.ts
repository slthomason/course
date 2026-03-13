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

@NgModule({
  declarations: [
    AppComponent,
    HelloWorldComponent,
    HelloWorldCliComponent,
    ParentComponent,
    ChildComponent,
    DirectiveExampleComponent,
    ReactiveFormExampleComponent,
    TemplateDrivenExampleComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
