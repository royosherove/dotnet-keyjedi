using KeyboardJedi.Core.Presenters;
using KeyboardJedi.Core.Services;
using KeyboardJedi.Core.Views;
using Moq;
using NUnit.Framework;

namespace KeyboardJedi.Tests.Presenters
{
	[TestFixture]
	public class MainFormPresenterTests
	{
		private MainFormPresenter mainFormPresenter;
		private Mock<IMainFormView> viewMock;
		private Mock<IJediSettings> jediSettingsMock;

		[SetUp]
		public void SetUp()
		{
			viewMock = new Mock<IMainFormView>();
			jediSettingsMock = new Mock<IJediSettings>();
			mainFormPresenter = new MainFormPresenter(viewMock.Object, jediSettingsMock.Object);
		}

		[Test]
		public void CanConstruct()
		{
			mainFormPresenter.HandleLoad();
		}
	}
}