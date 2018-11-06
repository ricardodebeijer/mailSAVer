import { Component } from '@angular/core';


const template = require('./app.component.html');

@Component({
    selector: 'app-home',
    template
})
export default class AppComponent {

    subject = "Onderwerp"
    sender = "Libor"
    receiver = "Michel"
    isIncoming = true
    path = ""
    
    async saveProject() {
         console.log('Test saveProject')
         path = "Save Project"
    }

    async saveAnders() {
        console.log('Test saveAnders')
        path = "Save Anders"
   }
}