<script lang="ts">
	import '../app.css';
	import Navbar from '$lib/components/Navbar.svelte';

	let { children } = $props();
</script>

<div class="flex flex-col min-h-screen">
	<Navbar />
	<main class="flex-grow container mx-auto px-4 py-8">
		{@render children()}
	</main>
	<footer class="bg-gray-100 dark:bg-gray-800 py-4">
		<div class="container mx-auto px-4 text-center text-gray-600 dark:text-gray-400 text-sm">
			&copy; {new Date().getFullYear()} Gabriel Martin. All rights reserved.
		</div>
	</footer>
</div>
