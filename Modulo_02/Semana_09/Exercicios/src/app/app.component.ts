import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  onSearchTextChanged(searchText: string) {
    console.log('Texto digitado:', searchText);
    // Faça aqui o que desejar com o texto digitado
  }
}
