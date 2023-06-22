import { JsonServerService } from '../json-server.service';

import { Component } from '@angular/core';
// import { staticMock } from 'src/assets/static_mock';

@Component({
  selector: 'app-notification-list',
  templateUrl: './notification-list.component.html',
  styleUrls: ['./notification-list.component.scss'],
})
export class NotificationListComponent {
  notificationItems!: any[];

  constructor(private jsonServerService: JsonServerService) {
    {
      this.jsonServerService.getPosts().subscribe({
        next: (data: any) => {
          this.notificationItems = data;
        },
        error: (error) => {
          console.error('Error!', error);
        }
      });
    }
  }
}
