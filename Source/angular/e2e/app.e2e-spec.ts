import { PersonalCashFlowTemplatePage } from './app.po';

describe('PersonalCashFlow App', function() {
  let page: PersonalCashFlowTemplatePage;

  beforeEach(() => {
    page = new PersonalCashFlowTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
