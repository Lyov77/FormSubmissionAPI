import { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import path from 'path'; // Import path module for resolving paths

export default defineConfig({
  base: '/', // Ensure base is set correctly
  server: {
    open: true,
    port: 5173,
  },
  plugins: [vue()],
  resolve: {
    alias: {
      '@': path.resolve(__dirname, 'src'), // Resolving '@' to the 'src' folder
    },
  },
});
