import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-git-user-list',
  templateUrl: './git-user-list.component.html',
  styleUrls: ['./git-user-list.component.css']
})
export class GitUserListComponent implements OnInit {
  gitUsers: any;
  constructor(private httpClient: HttpClient) {

  }


  ngOnInit(): void {
    this.httpClient.get("https://api.github.com/users").subscribe((response) => {
      this.gitUsers = response;
    })
  }


}
