import { expect, test } from '@playwright/test';

test('home page has documentation link', async ({ page }) => {
  await page.goto('/');
  const link = page.locator('a[href="https://svelte.dev/docs/kit"]');
  await expect(link).toBeVisible();
  await expect(link).toHaveText('svelte.dev/docs/kit');
});