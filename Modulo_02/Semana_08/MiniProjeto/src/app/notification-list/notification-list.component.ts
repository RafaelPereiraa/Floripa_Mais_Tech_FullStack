import { Component } from '@angular/core';
import { staticMock } from 'src/assets/static_mock';

@Component({
  selector: 'app-notification-list',
  templateUrl: './notification-list.component.html',
  styleUrls: ['./notification-list.component.scss']
})
export class NotificationListComponent {
  notificationItems: any[] = staticMock;
}
