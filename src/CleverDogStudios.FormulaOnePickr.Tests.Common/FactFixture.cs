using System;
using Moq;
using StructureMap.AutoMocking;

namespace CleverDogStudios.FormulaOnePickr.Tests.Common
{
    /// <summary>
    /// Simple wrapper to support StructureMap's AutoMocker and reduce repetitive code.
    /// </summary>
    /// <typeparam name="TSystemUnderTest">Type of System Under Test</typeparam>
    public abstract class FactFixture<TSystemUnderTest> where TSystemUnderTest : class
    {
        private MoqAutoMocker<TSystemUnderTest> _autoMocker;
        private TSystemUnderTest _systemUnderTest;

        protected TSystemUnderTest SystemUnderTest
        {
            get { return _systemUnderTest ?? (_systemUnderTest = AutoMocker.ClassUnderTest); }
        }

        private MoqAutoMocker<TSystemUnderTest> AutoMocker
        {
            get { return _autoMocker ?? (_autoMocker = CreateAutoMocker()); }
        }

        /// <summary>
        /// Injects object for the specified type, overriding the automocked object of the same type.
        /// </summary>
        protected void InjectCustomTypeFor<T>(T type) where T : class
        {
            AutoMocker.Inject(typeof(T), type);
        }

        protected void ArrangeConstructorDependencies()
        {
            Initialize();
        }

        /// <summary>
        /// Arranges constructor expectations for auto-mocked objects.
        /// </summary>
        protected void ArrangeConstructorDependencies(Action action)
        {
            if (action != null) action.Invoke();

            ArrangeConstructorDependencies();
        }

        /// <summary>
        /// For non-injectable objects, ie. with primitive constructor params, simply give the ability set the SUT.
        /// </summary>
        /// <param name="systemUnderTest"></param>
        protected void SetSystemUnderTest(TSystemUnderTest systemUnderTest)
        {
            _systemUnderTest = systemUnderTest;
        }

        /// <summary>
        /// Extracts the auto-mocked class from the auto mocker.
        /// </summary>
        protected Mock<T> AutoMock<T>() where T : class
        {
            return Mock.Get(AutoMocker.Get<T>());
        }

        private MoqAutoMocker<TSystemUnderTest> CreateAutoMocker()
        {
            return new MoqAutoMocker<TSystemUnderTest>();
        }

        /// <summary>
        /// Injects auto-mocked dependencies and sets and instance of SUT.
        /// </summary>
        private void Initialize()
        {
            if (_systemUnderTest == null) _systemUnderTest = AutoMocker.ClassUnderTest;
        }
    }
}
