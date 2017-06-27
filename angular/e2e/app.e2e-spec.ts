import { AbpNiucaiCoreTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: AbpNiucaiCoreTemplatePage;

  beforeEach(() => {
    page = new AbpNiucaiCoreTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
