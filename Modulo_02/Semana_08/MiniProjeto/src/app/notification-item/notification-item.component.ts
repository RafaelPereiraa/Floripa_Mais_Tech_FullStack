import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-notification-item',
  templateUrl: './notification-item.component.html',
  styleUrls: ['./notification-item.component.scss']
})
export class NotificationItemComponent {
  @Input() item: any; // Define item para ser recebido pelo componente que o chama
  read: boolean = false; // Propriedade para definir se a notificação foi lida ou não

  checkRead(){
    this.read = true;
  }
}

