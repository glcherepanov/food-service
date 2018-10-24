import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html'
})
export class UserListComponent {
  public users: UserDto[];

  public constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<UserDto[]>(baseUrl + 'api/User/UserDtos').subscribe(result => {
      this.users = result;
    }, error => console.error(error));
  }
};

interface UserDto{
  name: string,
  group: string,
  team: string
}