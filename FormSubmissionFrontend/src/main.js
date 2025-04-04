import { createApp } from 'vue';
import './style.css';
import App from './App.vue';
import router from './router/index.js'; // Ensure the router is imported

createApp(App).use(router).mount('#app');
