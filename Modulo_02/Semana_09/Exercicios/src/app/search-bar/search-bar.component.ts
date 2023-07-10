import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-search-bar',
  templateUrl: './search-bar.component.html',
  styleUrls: ['./search-bar.component.css']
})
export class SearchBarComponent {
  @Output() searchTextChanged = new EventEmitter<string>();

  onSearchChange(event: any) {
    const searchText = event.target.value;
    this.searchTextChanged.emit(searchText);
  }
}
