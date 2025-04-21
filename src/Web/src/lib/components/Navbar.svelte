<script>
  import ThemeToggle from "$lib/components/ThemeToggle.svelte";
</script>
<nav class="bg-white dark:bg-gray-800 shadow-md">
  <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
    <div class="flex justify-between h-16">
      <div class="flex items-center">
        <!-- Logo or Brand -->
        <span class="text-xl font-bold text-gray-800 dark:text-white">GCalc</span>
      </div>
      
      <!-- Navigation Items -->
      <div class="flex items-center space-x-4">
        <a href="/" class="text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white px-3 py-2 rounded-md text-sm font-medium">Home</a>
        <a href="/about" class="text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white px-3 py-2 rounded-md text-sm font-medium">About</a>
        <a href="/contact" class="text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white px-3 py-2 rounded-md text-sm font-medium">Contact</a>
        <ThemeToggle />
      </div>
    </div>
  </div>
</nav>