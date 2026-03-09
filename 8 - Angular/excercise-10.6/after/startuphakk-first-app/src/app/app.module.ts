import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HelloWorldComponent } from './hello-word.component';
import { HelloWorldCliComponent } from './hello-world-cli/hello-world-cli.component';
import { ChildComponent, ParentComponent } from './parent.component';
import { DirectiveExampleComponent } from './directive-example/directive-example.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HelloWorldComponent,
    HelloWorldCliComponent,
    ParentComponent,
    ChildComponent,
    DirectiveExampleComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
