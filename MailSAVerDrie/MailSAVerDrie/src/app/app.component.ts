import { Component } from '@angular/core';


const template = require('./app.component.html');

@Component({
    selector: 'app-home',
    template
})
export default class AppComponent {
    headerTitle = 'Welcome';

    async run() {
        /**
         * Insert your Outlook code here
         */

         console.log('Test')
    }
}