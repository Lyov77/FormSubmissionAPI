import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'

// https://vite.dev/config/
export default defineConfig({
  server: {
    open: true, // Automatically open the browser
    port: 5173, // Port for your local dev server
    historyApiFallback: true, // Enable history API fallback
  },
  plugins: [vue()],
})
